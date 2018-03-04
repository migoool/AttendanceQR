package com.attendance.jmm.qrcodescanner;

/**
 * Created by JMM on 3/2/2018.
 */

class Api {
    public static final String ipAddress = "http://192.168.43.183:8080/";
    public static final String qrRecord = ipAddress + "recordqr/functions/qr_read.php?id=";

    public static final String appTag = "ELECTIVES";
    public static final int getCode = 1024;
    public static final int postCode = 1025;
}
