   
     #include <18f26k22.h>
     #fuses NOWDT,NOLVP,XT                   
     #use delay(crystal=4mHz) 
     #use rs232(UART1,baud=9600)     
     #USE I2C(MASTER,I2C1,FORCE_SW,fast=30000)) //100k is max for RTC ds1307
     
      
      
      
      
