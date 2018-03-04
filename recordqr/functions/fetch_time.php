<?php 
	include("../db/database.php");

	date_default_timezone_set('Asia/Manila');
	$time = date("H:i:s");
	$date = date("Y-m-d");


	$read = mysqli_query($db,"SELECT qr_number FROM qrscan");
	 while($row=mysqli_fetch_assoc($read)){
	 	$qr 	= $row['qr_number']; 	
	 	echo $qr; /*qr = qr number*/
	 }


	 $read = mysqli_query($db,"SELECT * FROM users WHERE id = '$qr' ");
	 if(mysqli_num_rows($read) == 0 ){

	?>
		<script type="text/javascript">
			alert("NO ID IN DATABASE");
		</script>

	<?php

	 }
	 else{
	 	while($row=mysqli_fetch_assoc($read)){
	 		$name = " " .$row['lastname']. " , " . $row['firstname']. " " . substr($row['middlename'], 0,1);
		 	echo $name;
	 	}

 	 // CHECK TO DATABASE FOR TIMEOUT
	 $checkTime = mysqli_query($db,"SELECT * FROM record where qr ='$qr'AND `time` IS NOT NULL AND date_record = '$date' ");
	 while($row=mysqli_fetch_assoc($checkTime)){
		 	$time_in = $row['time'];	
		 	echo " " . $time_in;

	 }


	 if(mysqli_num_rows($checkTime) == 1){
 		$gapTime = date('g:i:s A', strtotime('+1 hour',strtotime($time_in)));
 		echo " " . $gapTime;

	 	if (time() >= strtotime($gapTime)) {
		   $store = mysqli_query($db,"UPDATE record SET timeout = '$time'
	   		WHERE qr = '$qr' ");
		   	?>
				<script type="text/javascript">
					alert("ALREADY LOGIN, TIMEOUT");
				</script>
			<?php

		}	  
	}
    else{
		  $store = mysqli_query($db,"INSERT INTO record(qr,name,`time`,date_record)
		   VALUES('$qr','$name','$time','$date') ");
	?>
			<script type="text/javascript">
				alert("LOGGING INFORMATION");
			</script>
	<?php 


		}
	 }
	 	
	?>