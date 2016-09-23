#include <Wire.h>

//const char* acc_addr = "0x1C";

void setup() {
  
	Serial.begin(9600);

  Wire.begin();
 
}

void loop() {

  Wire.beginTransmission(28);

  Serial.println(Wire.read());

  Wire.endTransmission();
  
}
