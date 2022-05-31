//Viral Science
//RFID
#include <SPI.h>
#include <MFRC522.h>
#include <Servo.h>
#include <Wire.h> 
#include <LiquidCrystal_I2C.h>

LiquidCrystal_I2C lcd(0x27,16,2);
#define SS_PIN 10
#define RST_PIN 9
#define LED_R 5 //define green LED pin
#define LED_G 4 //define red LED
#define BUZZER 2 //buzzer pin
MFRC522 mfrc522(SS_PIN, RST_PIN);   // Create MFRC522 instance.
Servo myServo; //define servo name
 
void setup() 
{
  
  Serial.begin(9600);   // Initiate a serial communication
  SPI.begin();// Initiate  SPI bus
  lcd.init();
  lcd.backlight();
  mfrc522.PCD_Init();   // Initiate MFRC522
  myServo.attach(3); //servo pin
  myServo.write(0); //servo start position
  pinMode(LED_R, OUTPUT);
  pinMode(LED_G, OUTPUT);
  pinMode(BUZZER, OUTPUT);
  noTone(BUZZER);
  lcd.setCursor(0,0);
  lcd.print("Put your card to");
  lcd.setCursor(0,1);
  lcd.print("the reader....->");
  Serial.println();
  

}
void loop() 
{
  // Look for new cards
  if ( ! mfrc522.PICC_IsNewCardPresent()) 
  {
    return;
  }
  // Select one of the cards
  if ( ! mfrc522.PICC_ReadCardSerial()) 
  {
    return;
  }
  
  //Show UID on serial monitor
  Serial.print("UID tag :");
  String content= "";
  byte letter;
  for (byte i = 0; i < mfrc522.uid.size; i++) 
  {
     Serial.print(mfrc522.uid.uidByte[i] < 0x10 ? " 0" : " ");
     Serial.print(mfrc522.uid.uidByte[i], HEX);
     content.concat(String(mfrc522.uid.uidByte[i] < 0x10 ? " 0" : " "));
     content.concat(String(mfrc522.uid.uidByte[i], HEX));
  }
  content.toUpperCase();
  if (content.substring(1) == "71 90 96 08") //change here the UID of the card/cards that you want to give access
  {
    
    lcd.clear();
    lcd.setCursor(3,0);
    lcd.print("Authorized");
    lcd.setCursor(5,1);
    lcd.print("Access");
    delay(500);
    digitalWrite(LED_G, HIGH);
    tone(BUZZER, 500);
    delay(300);
    noTone(BUZZER);
    myServo.write(180);
    delay(5000);
    lcd.clear();
    lcd.setCursor(0,0);
    lcd.print("Put your card to");
    lcd.setCursor(0,1);
    lcd.print("the reader....");
    myServo.write(0);
    digitalWrite(LED_G, LOW);
  }
 
 else   {
   
    lcd.clear();
    lcd.setCursor(0,0);
    lcd.print("Access denied...");
    lcd.setCursor(2,1);
    lcd.print("Arduino Tech");
    digitalWrite(LED_R, HIGH);
    tone(BUZZER, 300);
    delay(1000);
    digitalWrite(LED_R, LOW);
    noTone(BUZZER);
    delay(2000);
    lcd.clear();
    lcd.setCursor(0,0);
    lcd.print("Put your card to");
    lcd.setCursor(0,1);
    lcd.print("the reader....");
    }
}
 
 
