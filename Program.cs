using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Nokia nokia = new Nokia("+55038999999999", "Symbian","3310", "1234", 1);
Iphone iphone = new Iphone("+55038998999979", "IOS", "14 Pro Max", "1234", 6);

nokia.InstalarAplicativo("Jogo da cobrinha");
iphone.InstalarAplicativo("Telegram");
iphone.AcessarSiri();