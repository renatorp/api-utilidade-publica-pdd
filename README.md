# API de serviços para um cenário de uma transformação digital de um prefeitura

## Base URL:

*   http://api-utilidade-publica-pdd.azurewebsites.net/api/v1.0/

## Subresources
#### Consulta de IPTU
`GET imoveis/1/iptu`

#### Consulta de Coleta de Lixo 
`GET logradouros/{id}/solicitacoes/coletaslixo`

####  Solicitação de Poda de Árvore
`PUT logradouros/{id}/solicitacoes/podaArvore`

#### Solicitação de Construção de Meio-Fio
`PUT logradouros/{id}/solicitacoes/meiofio`

#### Solicitação de Recolhimento de Carros Abandonados 
`PUT logradouros/{id}/solicitacoes/recolhimentocarrosabandonados`

####  Solicitação de Desobstrução de Vias Públicas
`PUT logradouros/{id}/solicitacoes/desobstrucaoviapublica`

####  Solicitação de Desobstrução de Córregos
``PUT logradouros/{id}/solicitacoes/desobstrucaocorregos``

####  Solicitação de Coleta de Animal Morto
`PUT logradouros/{id}/solicitacoes/coletaanimalmorto`

####  Solicitação de Limpeza de Boca de Lobo
`PUT logradouros/{id}/solicitacoes/limpezabocalobo`

####  Consulta de Histórico de Aluno de Rede Pública
`GET alunos/{codaluno}/historico`

#### Pedido de adoção de cães 
`POST pedidos/adocaocao`

#### Pedido de adoção de gatos
`POST pedidos/adocaogato`

#### Consulta de pedidos
`GET pedidos/{id}`
