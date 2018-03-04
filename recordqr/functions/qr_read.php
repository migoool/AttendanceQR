<?php
    session_start();

class rfid{
 public $link='';
 
 function __construct($id){
  $this->connect();
  $this->storeInDB($id);
 }
 
 function connect(){
  $this->link = mysqli_connect('localhost','root','P@ssw0rd2017','attendanceqr') or die ('error Connecting to Database'); 
 }
 
 function storeInDB($id){
  $db = $this->link; 
  
  $query = mysqli_query($db,"SELECT qr_number FROM qrscan");

  if (mysqli_num_rows($query) == 0){
    $sql = mysqli_query($db," INSERT into qrscan (qr_number) VALUES('$id')  ");
  }
  else{
    $sql = mysqli_query($db," UPDATE qrscan SET qr_number = '$id' WHERE id= '1' ");
  }

  }
 
}


if ($_GET['id'] != NULL){
 $rfid=new rfid($_GET['id']);
}


?>


<?php include('fetch_time.php'); ?>