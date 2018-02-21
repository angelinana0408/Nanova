unsigned long now;

void setup(){
  Serial.begin(9600);
}
void loop(){
  Serial.print("Time: ");
  now = micros();
  //prints time since program started
  Serial.println(now);
  // wait a second so as not to send massive amounts of data
  delay(100);
}

