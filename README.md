# FatturaElettronicaPA.WebServices
Il namespace `FatturaElettronicaPA.WebServices` raccoglie i client che
consentono di consultare i [Web Service per la Fatturazione Elettronica][1]
messi a disposizione dalla Pubblica Amministrazione. 

Sono disegnati in maniera da esporre tutti la stessa interfaccia ed essere al
tempo stesso semplici e leggeri. Al momento lavorano in modalità sincrona ma
l'obiettivo è di renderli tutti asincroni.

## Authorization ID
Per l'utilizzo dei Web Services è necessario richiedere una specifica
autorizzazione. L'Authorization Id è gratuito ed il rilascio è immediato, ma
bisogna compilare un [apposito questionario][2]. 

## Codice Univoco di Fatturazione
Questo client interroga il corrispondente Web Service PA per verificare la
validità di un Codice Univoco di "Ufficio destinatario di Fatturazione
Elettronica e dati SFE". Se il codice è valido vengono anche restitute tutte le
informazioni diponibili sull'ufficio.

    var codiceUnivocoWebService = new CodiceUnivocoFatturazioneWebService()

    // Authorization Id ricevuto dall'ente.
    codiceWebService.AuthId = "<auth Id>";
    // Codice univoco dell'ufficio che ci interessa
    codiceWebService.CodiceUfficio = "KN3VNW";

    codiceWebService.PerformRequest();

    if (codiceWebService.Ufficio == null) return;

    Console.WriteLine(codiceWebService.Ufficio.Comune);

## Dati Ente
Questo client interroga il corrispondente Web Service PA per verificare la
validità di un Codice Ente. Se il codice è valido vengono anche restitute tutte
le informazioni diponibili sull'ente.

    var enteWebService = new DatiEnteWebService {AuthId = "<auth Id>", CodiceEnte = "c_h199"};

    enteWebService.PerformRequest();
    
    if (enteWebService.Ente == null) return;

    Console.WriteLine(enteWebService.Ente.Comune);

[1]: http://www.indicepa.gov.it/documentale/webservices.php
[2]: http://www.indicepa.gov.it/registr-user-ws/ws-registrazione-start.php
