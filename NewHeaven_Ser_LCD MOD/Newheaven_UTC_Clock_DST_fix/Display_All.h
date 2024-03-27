 
 
 
 
    void  Display_All_Regs() {
       // Convert BCD to decimal
        second = (second >> 4) * 10 + (second & 0x0F);
        minute = (minute >> 4) * 10 + (minute & 0x0F);
        hour =   (hour   >> 4) * 10 + (hour   & 0x0F);
        date =   (date   >> 4) * 10 + (date   & 0x0F);
        month =  (month  >> 4) * 10 + (month  & 0x0F);
        year =   (year   >> 4) * 10 + (year   & 0x0F);
     // End conversion
    
       
         putc (0x1B);  // cursor escape
         putc (0x00);
         printf ("Hours->%u",hour);
         delay_ms(50);
         
         putc (0x1B);  // cursor escape
         putc (0x1a); 
         printf ("%u",hour);
         delay_ms(50);
         
         putc (0x1B);  // cursor escape
         putc (0x09);  
         printf (" Min->");
         delay_ms(50);
         
         putc (0x1B);  // cursor escape
         putc (0x0f);
         printf ("%u ",minute);
         delay_ms(2000);
    // clear the area where the hours and minutes were displayed    
         putc (0x1B);  // cursor escape
         putc (0x00);
         printf ("  WB9IXS UTC CLOCK  ");
         Read_All_RTC_Regs();
      
    }
