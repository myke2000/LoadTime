   
   ///                                                                   /// 
   ///                                                                   ///
   ///       (0xD0) base address ds1307                                  ///
   ///       THIS DRIVER WORKS WITH A DS3231 MODULE ALSO                 ///
   ///                                                                   ///
   ///                                                                   ///  
      
              
       int8  second, minute, hour, date, month, year, day;
       int8  utc_hour;
       
    void ds1307_display(){
     // Convert BCD to decimal
        second = (second >> 4) * 10 + (second & 0x0F);
        minute = (minute >> 4) * 10 + (minute & 0x0F);
        hour =   (hour   >> 4) * 10 + (hour   & 0x0F);
        date =   (date   >> 4) * 10 + (date   & 0x0F);
        month =  (month  >> 4) * 10 + (month  & 0x0F);
        year =   (year   >> 4) * 10 + (year   & 0x0F);
     // End conversion
     
  // ******************************************************
  //   THIS SECTION PRINTS THE UTC TIME                   *
  // ******************************************************
  
 //print UTC hrs
             utc_hour = hour +6; 
             if (hour >17 && hour <25) {utc_hour = hour -18;}
          if (utc_hour<10){// add leading zero if hours <10   
                putc (0xfe); 
                putc (0x45); // cursor psn cmd
                putc (0x17); // cursor psn
                printf("0");
                putc (0xfe);  // cursor psn cmd
                putc (0x18);  // put the one's digit of the hours here
                printf ("%u",utc_hour);
             } 
          if (utc_hour>9){ // if the hours is >10 then no leading zero's       
               putc (0xfe); 
               putc (0x45); // cursor psn cmd
               putc (0x17);  // cursor psn
               printf ("%u",utc_hour);
             } 
     
 //print UTC minutes    
          if (minute<10){  // add leading zero if hours <10
             putc (0xfe);  
             putc (0x45);  // cursor psn cmd
             putc (0x1a);  // cursor psn
             printf("0");             
             putc (0xfe);   
             putc (0x45);  // cursor psn cmd
             putc (0x1b);  // put the one's digit of the hours here
             printf ("%u",minute);
             } 
          if (minute>9){   // if the hours is >10 then no leading zero's
             putc (0xfe);  
             putc (0x45);  // cursor psn cmd
             putc (0x1a);  // cursor psn
             printf ("%u",minute);
             }  
        
  // ******************************************************
  //   THIS SECTION PRINTS THE CURRENT TIME               *
  // ******************************************************
  
 //print CT hrs    
          if (hour<10){    // add leading zero if hours <10
             putc (0xFE);  
             putc (0x45);  // cursor psn cmd
             putc (0x20);  // cursor psn
             printf("0");
             putc (0xFE);  // cursor psn
             putc (0x23);  // put the one's digit of the hours here
             printf ("%u",hour);
             } 
          if (hour>9){     // if the hours is >10 then no leading zero's
             putc (0xFE);  
             putc (0x45);  // cursor psn cmd
             putc (0x20);  // cursor psn
             printf ("%u",hour);
             } 
      
 //print CT minutes    
          if (minute<10){  // add leading zero if minutes <10
             putc (0xFE);  
             putc (0x45);  // cursor psn cmd
             putc (0x23);  // cursor psn
             printf("0");
             putc (0xFE);  
             putc (0x45);  // cursor psn cmd
             putc (0x24);  // put the one's digit of the minutes here
             printf ("%u",minute);
             } 
          if (minute>9){   // if the minutes is >10 then no leading zero's
             putc (0xFE);  
             putc (0x45);  // cursor psn cmd
             putc (0x23);  // cursor psn
             printf ("%u",minute);
             }   

 //print seconds 
            
          if (second<10){  // add leading zero if seconds <10
             putc (0xFE);
             putc (0x45);  // cursor psn cmd
             putc (0x26);  // cursor psn             
             printf("0");
             putc (0xFE);  
             putc (0x45);  // cursor psn cmd
             putc (0x27);  // put the one's digit of the seconds here
             printf ("%u",second);
             } 
          if (second>9){   // if the seconds is >10 then no leading zero's
             putc (0xFE);  
             putc (0x45);  // cursor psn cmd
             putc (0x26);  // cursor psn
             printf ("%u",second);
             } 

 //print day
             putc (0xFE);  
             putc (0x45);  // cursor psn cmd
             putc (0x59);  // cursor psn
             if (day==1){printf ("SUN");}
             if (day==2){printf ("MON");}
             if (day==3){printf ("TUE");}
             if (day==4){printf ("WED");}
             if (day==5){printf ("THU");}
             if (day==6){printf ("FRI");}
             if (day==7){printf ("SAT");}               
  //print month
             putc (0xFE);  
             putc (0x45);  // cursor psn cmd
             putc (0x5D);  // cursor psn            
             if (month==1){printf  ("JAN");}
             if (month==2){printf  ("FEB");}
             if (month==3){printf  ("MAR");}
             if (month==4){printf  ("APR");}
             if (month==5){printf  ("MAY");}
             if (month==6){printf  ("JUN");}
             if (month==7){printf  ("JUL");} 
             if (month==8){printf  ("AUG");}
             if (month==9){printf  ("SEP");}
             if (month==10){printf ("OCT");}
             if (month==11){printf ("NOV");}
             if (month==12){printf ("DEC");}             
  //print date            
             putc (0xFE);  
             putc (0x45);  // cursor psn cmd
             putc (0x60);  // cursor            
             printf (" %u  ",date);
             
       } //END ds1307_display  
     
    
    void write_Seconds()
      {
       i2c_start();
       i2c_write(0xD0); //base address ds1307
       i2c_write(0);    //seconds address
       i2c_write(0x00);  //seconds are set to zero (00)
       i2c_stop();  
       delay_ms(10);
      }
     
    void Write_Minutes()
      {
       i2c_start();
       i2c_write(0xD0);   //base address ds1307
       i2c_write(0x01);   //minutes reg address
       i2c_write(minute); //set minutes reg to this value
       i2c_stop();
       delay_ms(10);
       break;
      }
     
    void Write_Hours()
      {
       i2c_start();
       i2c_write(0xD0); //base address ds1307
       i2c_write(0x02); //hours reg address
       i2c_write(hour); //set hours to this value
       i2c_stop();
       delay_ms(10);
       break;
      }
       
    void Write_Days()
      {
       i2c_start();
       i2c_write(0xD0); //base address ds1307
       i2c_write(0x03); //days reg address
       i2c_write(day);  //set days reg to this value
       i2c_stop(); 
       delay_ms(10);
       break;
      }

    void Write_Date()
      {
       i2c_start();
       i2c_write(0xD0); //base address ds1307
       i2c_write(0x04); //date reg address
       i2c_write(date); //set date reg to this value
       i2c_stop(); 
       delay_ms(10);
       break;
      }

    void Write_Months()
      {
       i2c_start();
       i2c_write(0xD0); //base address ds1307
       i2c_write(0x05); //months reg address
       i2c_write(month);//set months reg to this value
       i2c_stop(); 
       delay_ms(10);
       break;
      }
  
    void Write_Years()
      {
       i2c_start();
       i2c_write(0xD0); //base address ds1307
       i2c_write(0x06); //year reg address
       i2c_write(year); //set year reg to this value
       i2c_stop();
       delay_ms(10);
      }
  
    void Read_All_RTC_Regs() 
      { 
       i2c_start();                  // Start I2C protocol
       i2c_write(0xD0);              // DS1307 address
       i2c_write(0);                 // Send register address
       i2c_start();                  // Restart I2C
       i2c_write(0xD1);              // Initialize data read
       second = i2c_read(1);         // Read seconds from register 0
       minute = i2c_read(1);         // Read minutes from register 1
       hour   = i2c_read(1);         // Read hour from register 2
       day    = i2c_read(1);         // Read day from register 3
       date   = i2c_read(1);         // Read date from register 4
       month  = i2c_read(1);         // Read month from register 5
       year   = i2c_read(0);         // Read year from register 6
       i2c_stop();                   // Stop I2C protocol
       ds1307_display();             // Display time & calendar
       delay_ms(100);                // This delay stops the LCD fom flashing
      }//end read_All_RTC_Regs       
      
    void Read_All_RTC_Regs_At_Start() //read all ds1307 regs without display
      { 
       i2c_start();                  // Start I2C protocol
       i2c_write(0xD0);              // DS1307 address
       i2c_write(0);                 // Send register address
       i2c_start();                  // Restart I2C
       i2c_write(0xD1);              // Initialize data read
       second = i2c_read(1);         // Read seconds from register 0
       minute = i2c_read(1);         // Read minuts from register 1
       hour   = i2c_read(1);         // Read hour from register 2
       day    = i2c_read(1);         // Read day from register 3
       date   = i2c_read(1);         // Read date from register 4
       month  = i2c_read(1);         // Read month from register 5
       year   = i2c_read(0);         // Read year from register 6
       i2c_stop(); // Stop I2C protocol
       delay_ms(10);                // This delay stops the LCD fom flashing
      }//end read_All_RTC_Regs_At_Start    
      
  
