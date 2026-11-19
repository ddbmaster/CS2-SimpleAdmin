<p align="center">
  <a href="https://github.com/daffyyyy/CS2-SimpleAdmin/actions/workflows/build.yml">
    <img src="https://github.com/daffyyyy/CS2-SimpleAdmin/actions/workflows/build.yml/badge.svg" alt="Build and Publish" />
  </a>
<a href="https://github.com/daffyyyy/CS2-SimpleAdmin/releases/latest">
  <img src="https://img.shields.io/github/v/release/daffyyyy/CS2-SimpleAdmin?color=orange" alt="GitHub Release" />
</a>
  <img src="https://img.shields.io/badge/Made_with-a_lot_of_tea_%F0%9F%8D%B5-red" alt="Mit viel Tee gemacht 🍵" />
</p>

[![Dem Support-Discord beitreten](https://img.shields.io/badge/Discord-Support-blue?logo=discord&logoColor=white)](https://discord.com/channels/1160907911501991946/1180627186865156126)
# CS2-SimpleAdmin

---

> **Verwalte deinen Counter-Strike-2-Server mit einfachen Befehlen!**  
> CS2-SimpleAdmin ist ein Plugin, mit dem du deinen Counter-Strike-2-Server über benutzerfreundliche Befehle ganz einfach verwalten kannst. Ob du Spieler bannst, Teams verwaltest oder Servereinstellungen anpasst – CS2-SimpleAdmin hat alles dabei.

---

## 🚀 Funktionen

- 🎮 **Einfache, intuitive Befehle:** Spieler, Teams, Banns und Servereinstellungen über ein leicht verständliches Befehlssystem verwalten.
- 🗄 **Vollständige Datenbankanbindung:** Zuverlässiges MySQL-Backend sowie optionale, experimentelle SQLite-Unterstützung für die dauerhafte Datenspeicherung.
- ⚡ **Effizient und schlank:** Darauf ausgelegt, möglichst wenig Serverressourcen zu verbrauchen und trotzdem zuverlässig zu funktionieren.
- 🚨 **Echtzeit-Benachrichtigungen:** Sofortige Benachrichtigungen im Spiel und auf Discord, damit Admins und Spieler immer informiert sind.
- 🎛 **Benutzerfreundliche Admin-Oberfläche:** Plugin-Menüs für eine schnelle und effiziente Verwaltung ohne komplizierte Befehle.
- 🔄 **Mehrserver-Unterstützung:** Daten über mehrere Server hinweg nahtlos verwalten und synchronisieren.
- 🧩 **Modular und erweiterbar:** Das Plugin über die API mit eigenen Befehlen und Automatisierungen anpassen.
- 📜 **Lückenlose Protokolle:** Alle Admin-Aktionen werden genau protokolliert, damit jederzeit nachvollziehbar ist, wer was getan hat.
- 🌐 **Discord-Integration:** Logs und Warnungen an deine Discord-Kanäle senden, um alles zentral im Blick zu behalten.
- 🤝 **Von der Community getragen:** Open Source mit laufenden Beiträgen einer engagierten Community.

---

## ⚙️ Voraussetzungen

**Stelle sicher, dass alle folgenden Abhängigkeiten installiert sind, bevor du fortfährst:**
- [CounterStrikeSharp](https://github.com/roflmuffin/CounterStrikeSharp)  
- [PlayerSettings](https://github.com/NickFox007/PlayerSettingsCS2) – wird von MenuManagerCS2 benötigt
- [AnyBaseLibCS2](https://github.com/NickFox007/AnyBaseLibCS2) – wird von PlayerSettings benötigt
- [MenuManagerCS2](https://github.com/NickFox007/MenuManagerCS2)
- MySQL-Datenbank / SQLite

---

## 🚀 Erste Schritte

1. **Repository klonen oder herunterladen:**  
   Lade das Repository herunter oder klone es und veröffentliche es in dein Verzeichnis `addons/counterstrikesharp/plugins/`.

2. **Konfiguration beim ersten Start:**  
   Beim ersten Start wird eine Konfigurationsdatei erzeugt unter:
   ```
   addons/counterstrikesharp/configs/plugins/CS2-SimpleAdmin/CS2-SimpleAdmin.json
   ```
   Bearbeite diese Datei, um die Plugin-Einstellungen an die Anforderungen deines Servers anzupassen.

3. **Viel Spaß bei der Serververwaltung!**  
   Nutze die Befehle des Plugins, um deinen Server ganz einfach zu verwalten.

---

## 📁 Konfiguration

Die Konfigurationsdatei (`CS2-SimpleAdmin.json`) wird nach dem ersten Start automatisch erzeugt. Sie enthält die Einstellungen für die MySQL-Verbindung, die Befehlsberechtigungen und weitere Plugin-spezifische Optionen.

---

## 📚 Dokumentation & Support

Die vollständige Dokumentation, Anleitungen, Tutorials und die Entwickler-API-Referenz findest du hier:  
[CS2-SimpleAdmin Wiki](https://cs2-simpleadmin.daffyy.dev)
Leider Existiert diese Seite nicht mehr.
---

## 🛠️ Entwicklung

Dieses Projekt begann als Grundlage für andere Plugins, hat sich aber zu einem eigenständigen Admin-Verwaltungstool entwickelt. Beiträge sind willkommen! Wenn du bei der Entwicklung helfen möchtest oder Ideen für neue Funktionen hast, reiche gerne einen Pull Request ein oder eröffne ein Issue.

---

## 🤝 Mitwirken & Feedback

Hilf mit, CS2-SimpleAdmin zu verbessern, indem du:
- Fehler meldest oder Funktionen auf GitHub vorschlägst
- Pull Requests mit Verbesserungen einreichst
- dich an Diskussionen beteiligst und Ideen teilst

---

## 💡 Danksagung

Dieses Projekt ist von der Arbeit von [Hackmastr](https://github.com/Hackmastr/css-basic-admin/) inspiriert. Danke für die Grundlagenarbeit!

---

## ☕ Entwicklung unterstützen

Wenn dir CS2-SimpleAdmin gefällt, kannst du die laufende Entwicklung unterstützen:  
[![Buy me a coffee](https://ko-fi.com/img/githubbutton_sm.svg)](https://ko-fi.com/Y8Y4THKXG)

---

## 📄 Lizenz
Dieses Projekt steht unter der GPL-3.0-Lizenz – Details findest du in der Datei [LICENSE](LICENSE).
