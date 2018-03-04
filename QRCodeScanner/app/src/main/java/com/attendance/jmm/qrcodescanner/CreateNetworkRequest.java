package com.attendance.jmm.qrcodescanner;

import android.os.AsyncTask;

import java.util.HashMap;

/**
 * Created by JMM on 3/2/2018.
 */

class CreateNetworkRequest extends AsyncTask<Void, Void, String> {
    private static final int CODE_GET_REQUEST = 1024;
    private static final int CODE_POST_REQUEST = 1025;

    String url;
    HashMap<String, String> params;
    int requestCode;


    CreateNetworkRequest(String url, HashMap<String, String> params, int requestCode) {
        this.url = url;
        this.params = params;
        this.requestCode = requestCode;
    }


    @Override
    protected String doInBackground(Void... voids) {
        RequestHandler requestHandler = new RequestHandler();

        if (requestCode == CODE_POST_REQUEST)
            return requestHandler.sendPostRequest(url, params);


        if (requestCode == CODE_GET_REQUEST)
            return requestHandler.sendGetRequest(url);

        return null;
    }

    @Override
    protected void onPreExecute() {
        super.onPreExecute();

    }

    @Override
    protected void onPostExecute(String s) {
        super.onPostExecute(s);

    }



}