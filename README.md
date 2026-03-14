# 🧾 Automação para Download de NFC-e

Este projeto consiste em uma automação desenvolvida em **C#** para otimizar o processo de download de **NFC-e (Nota Fiscal de Consumidor Eletrônica)** em sistemas de PDV que não possuem funcionalidade de **exportação em massa**.

---

## 📸 Demonstração

![Automação NFCe](AUTOMACAO.png)

---

## 📌 Problema

Uma empresa responsável pela gestão do **PDV de uma rede de mercados** precisava baixar **mais de 1000 NFC-e** para envio à contabilidade.

O sistema de PDV permitia apenas o download **nota por nota**, tornando o processo:

- demorado  
- repetitivo  
- sujeito a erros humanos  

---

## 🚀 Solução

Foi desenvolvida uma automação que executa o processo automaticamente, simulando as interações necessárias no sistema.

A aplicação:

- 📥 lê uma **lista de números de NFC-e**
- 🔎 realiza a **busca automática no sistema**
- 💾 executa o **download dos XML**
- 📊 exibe **barra de progresso**
- 📝 registra **logs de execução**
- ⛔ permite **interromper o processo a qualquer momento**

---

## ⚙️ Desafio técnico

Como os arquivos estão em **ambiente remoto**, cada computador apresenta uma performance diferente durante a execução.

Para evitar falhas ou travamentos, foi implementado um:

**Controle de velocidade ajustável**

Isso permite que a automação adapte o tempo de execução conforme a performance da máquina.

---

## 🛠 Tecnologias utilizadas

- C#
- .NET
- WinForms
- Automação de interface (SendKeys)

---

## ⏱ Tempo de desenvolvimento

A primeira versão funcional da automação foi desenvolvida em aproximadamente:

**40 minutos**

---

## 🎯 Objetivo

Reduzir drasticamente o tempo gasto em tarefas repetitivas e melhorar a eficiência no processo de coleta de documentos fiscais.

---

## 📄 Licença

Este projeto é apenas para fins educacionais e demonstração de automação de processos.
