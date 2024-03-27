   
     #include <18f4520.h>
     #DEVICE ICD=TRUE
     #fuses NOWDT,NOLVP,XT                   
     #use delay(crystal=20mHz) 
     #USE RS232 (baud=9600,xmit=pin_c6,rcv=pin_c7,errors,stream=PCdata)
    //#use rs232(stream=PCdata,UART1,baud=9600)     
     #USE I2C(MASTER,I2C1,FORCE_SW,fast=30000)) //100k is max for RTC ds1307
     
      
      
      
      
