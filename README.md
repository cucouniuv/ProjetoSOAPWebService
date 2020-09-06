# O que é este projeto?
Projeto de estudo sobre criar um Web Service SOAP com .NET Core

Conteúdo que utilizei como referência:

https://dottutorials.net/creating-soap-web-services-dot-net-core-tutorial/

# Para testar

POST

https://localhost:5001/Service.asmx

Enviar no Body um XML com:

```
<?xml version="1.0" encoding="utf-8"?>
<soap:Envelope xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns:xsd="http://www.w3.org/2001/XMLSchema" xmlns:soap="http://schemas.xmlsoap.org/soap/envelope/">
  <soap:Body>
    <Test xmlns="http://tempuri.org/">
      <s>Essa é a minha string</s>
    </Test>
  </soap:Body>
</soap:Envelope>
```

e deve retornar algo como:

```
<?xml version="1.0" encoding="utf-8"?>
<s:Envelope xmlns:xsd="http://www.w3.org/2001/XMLSchema" xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns:s="http://schemas.xmlsoap.org/soap/envelope/">
    <s:Body>
        <TestResponse xmlns="http://tempuri.org/">
            <TestResult>Essa é a minha string (Passou por SampleService - método Test)</TestResult>
        </TestResponse>
    </s:Body>
</s:Envelope>
```

# Criado com

* Microsoft Visual Studio Community 2019
* .NET Core 3.1
* SoapCore 1.0.0

