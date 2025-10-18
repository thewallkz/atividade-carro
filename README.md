// 1. Criar uma instância (objeto) da classe Carro
meuCarro = novo Carro()
meuCarro.cor = "Vermelho"
meuCarro.modelo = "Esportivo"
meuCarro.velocidadeMaxima = 180.0
meuCarro.velocidadeAtual = 0.0

// 2. Ligar o carro
meuCarro.liga()
// Saída esperada: "Carro ligado"

// 3. Acelerar o carro
meuCarro.acelera(35.5)
imprimir("Velocidade atual: " + meuCarro.velocidadeAtual)
// Saída esperada: "Velocidade atual: 35.5"

// 4. Verificar a marcha atual
marchaAtual = meuCarro.passarMarcha()
imprimir("Marcha atual: " + marchaAtual)
// Saída esperada: "Marcha atual: 2"

// 5. Acelerar mais
meuCarro.acelera(50.0)
imprimir("Velocidade atual: " + meuCarro.velocidadeAtual)
// Saída esperada: "Velocidade atual: 85.5"

marchaAtual = meuCarro.passarMarcha()
imprimir("Marcha atual: " + marchaAtual)
// Saída esperada: "Marcha atual: 4"
