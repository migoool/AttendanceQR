package com.attendance.jmm.qrcodescanner;

import android.app.ProgressDialog;
import android.content.Context;
import android.content.Intent;
import android.content.pm.PackageManager;
import android.hardware.Camera;
import android.os.Handler;
import android.os.Vibrator;
import android.support.annotation.NonNull;
import android.support.v4.app.ActivityCompat;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.util.Log;
import android.util.SparseArray;
import android.view.SurfaceHolder;
import android.view.SurfaceView;
import android.widget.TextView;
import android.widget.Toast;

import com.google.android.gms.vision.CameraSource;
import com.google.android.gms.vision.Detector;
import com.google.android.gms.vision.barcode.Barcode;
import com.google.android.gms.vision.barcode.BarcodeDetector;

import java.io.IOException;
import java.security.Policy;
import java.util.HashMap;

public class MainActivity extends AppCompatActivity {

    SurfaceView cameraPreview;
    TextView textResult;
    BarcodeDetector barcodeDetector;
    CameraSource cameraSource;
    final int RequestPermissionID = 1001;


    @Override
    public void onRequestPermissionsResult(int requestCode, @NonNull String[] permissions, @NonNull int[] grantResults) {
        switch (requestCode) {
            case RequestPermissionID: {
                if (grantResults[0] == PackageManager.PERMISSION_GRANTED) {
                    if (ActivityCompat.checkSelfPermission(this, android.Manifest.permission.CAMERA) != PackageManager.PERMISSION_GRANTED) {

                        return;
                    }
                    try {
                        cameraSource.start(cameraPreview.getHolder());
                    } catch (IOException e) {
                        e.printStackTrace();
                    }
                }
            }break;
        }
    }

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        cameraPreview = (SurfaceView) findViewById(R.id.cameraPreview);
        textResult = (TextView) findViewById(R.id.textResult);

        barcodeDetector = new BarcodeDetector.Builder(MainActivity.this)
                .setBarcodeFormats(Barcode.QR_CODE)
                .build();

        cameraSource = new CameraSource.Builder(this, barcodeDetector)
                .setRequestedPreviewSize(980, 780)
                .build();


        cameraPreview.getHolder().addCallback(new SurfaceHolder.Callback() {
            @Override
            public void surfaceCreated(SurfaceHolder holder) {
                if (ActivityCompat.checkSelfPermission(getApplicationContext(), android.Manifest.permission.CAMERA) != PackageManager.PERMISSION_GRANTED) {
//                    Request Permission
                    ActivityCompat.requestPermissions(MainActivity.this,
                            new String[]{android.Manifest.permission.CAMERA},RequestPermissionID);
                    return;
                }
                try{
                    cameraSource.start(cameraPreview.getHolder());
                }catch (IOException e){
                    e.printStackTrace();
                }
            }

            @Override
            public void surfaceChanged(SurfaceHolder holder, int format, int width, int height) {

            }

            @Override
            public void surfaceDestroyed(SurfaceHolder holder) {
                cameraSource.stop();
            }
        });

        barcodeDetector.setProcessor(new Detector.Processor<Barcode>() {
            @Override
            public void release() {

            }

            @Override
            public void receiveDetections(Detector.Detections<Barcode> detections) {
                final SparseArray<Barcode> qrcodes = detections.getDetectedItems();
                if (qrcodes.size() != 0){
                    textResult.post(new Runnable() {
                        @Override
                        public void run() {
                            Vibrator vibrator = (Vibrator) getApplicationContext().getSystemService(Context.VIBRATOR_SERVICE);
                            vibrator.vibrate(100);
                            textResult.setText(qrcodes.valueAt(0).displayValue);
                            recordQR();
                            Log.d(Api.appTag, "SCANNED");
                        }
                    });
                }

            }
        });

    }

    private void recordQR() {
        final String id = textResult.getText().toString().trim();

//        final ProgressDialog progressDialog = new ProgressDialog(MainActivity.this);
//        progressDialog.setMessage("Saving id#- "+ id +" to records ..");
//        progressDialog.show();

        CreateNetworkRequest request = new CreateNetworkRequest(Api.qrRecord + id, null, Api.getCode);
        request.execute();

        final Toast toast = Toast.makeText(getApplicationContext(), "ID#" + id + " Saved", Toast.LENGTH_SHORT);
        toast.show();
        Handler handler = new Handler();
        handler.postDelayed(new Runnable() {
            @Override
            public void run() {
                toast.cancel();
            }
        }, 500);

//
//        final Handler handler = new Handler();
//        handler.postDelayed(new Runnable() {
//            @Override
//            public void run() {
//                progressDialog.dismiss();
//                Log.d(Api.appTag, "SENT");
//
//            }
//        }, 2000);
    }
}
