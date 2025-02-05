# CheapSharkAPI

Este programa foi desenvolvido para realizar uma requisição à API **CheapShark** e obter uma lista de promoções de jogos disponíveis. Ele utiliza o endpoint `https://www.cheapshark.com/api/1.0/deals` para buscar os dados e exibe as informações de forma organizada e fácil de entender.

## Funcionalidades

1. **Requisição à API CheapShark**:
   - O programa faz uma requisição HTTP GET ao endpoint `https://www.cheapshark.com/api/1.0/deals` para obter uma lista de promoções de jogos.

2. **Exibição de Promoções**:
   - Após receber os dados da API, o programa exibe as seguintes informações para cada jogo em promoção:
     - **Título do Jogo**: Nome do jogo que está em promoção.
     - **Preço Original**: Preço original do jogo antes do desconto.
     - **Preço com Desconto**: Preço atual do jogo com o desconto aplicado.
     - **Percentual de Economia**: Percentual de desconto aplicado ao jogo.

3. **Organização dos Dados**:
   - As informações são exibidas de forma clara e organizada, facilitando a leitura e comparação entre as diferentes promoções.

### Como Usar

1. **Clone o repositório** para o seu ambiente local:
   ```bash
   git clone https://github.com/Carlos4415/CheapSharkAPI.git