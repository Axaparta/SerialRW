void setup()
{
  Serial.begin(9600);
}

void loop()
{
  if (Serial.available() > 0)
  {
    // get incoming byte:
    int inByte = Serial.read();
    Serial.write(inByte);
  }
}
