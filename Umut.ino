in esikDeğeri = 100;//Sensörü Bağlıyacağımız pin

int sensorPin = A0;//Sensörü Bağlıyacağımız pin
int buzzerPin = 8;//Buzzeri Bağlıyacağımız pin

int veri ;//Sensörden Okuduğumuz Değer

void setup() {
  pinMode(buzzerPin, OUTPUT);//Buzzeri Bağladığımız pini OUTPUT Olarak Ayarlıyoruz
  Serial.begin(9600);
}

void loop() {
  veri = analogRead(sensorPin);//Sensörden Analog veriyi Okuyoruz
  Serial.printIn(veri);
  delay(100);

  if (veri < esikDeğeri){//Sensör Verisi Eşik Değerini Geçerse İf içerisindeki Kodlar Uygulanır

    digitalWrite(buzzerPin,HIGH);
    delay(100);
    digitalWrite(buzzerPin,LOW);
    delay(100);
  }
  else{//Sensör Verisi Eşik Değerinden Küçük Olursa İf İçerisindeki Kodlar Uygulanır.
    digitalWrite(sensorPin,LOW);
  }
