# Raumschiff Tonstudio – Sound und Space im Virtuellen

---

### Idee
* Dieses Projekt entstand im Rahmen des Aufbauseminars [_Auditory Spaces: Sound als Gestaltungsmittel in VR und AR_](https://lehre.idh.uni-koeln.de/lehrveranstaltungen/sosem20/auditory-spaces-sound-als-gestaltungsmittel-in-vr-und-ar/) am Institut für Digital Humanities der Universität zu Köln.
* Wir haben es uns als Ziel gesetzt, das Hörspiel [_Raumschiff Tonstudio – Bericht über das Innere einer Kapsel und deren Bewohner_](https://www.deutschlandfunkkultur.de/hoerspiel-ueber-den-brillanten-sound-raumschiff-tonstudio.3684.de.html?dram:article_id=456412) in einen virtuellen Raum zu übersetzen
* Der virtuelle Raum soll das Auditive unterstützen um das Hörspiel zu verbildlichen, jedoch steht das Hörspiel im Fokus.
* Einzelne Szenen sollen aus dem Hörspiel herausgenommen und visualisiert werden um ein Narrativ zu bilden, womit eine ganze Geschichte entsteht.
* Wir wollen einen Mix aus vorgegebenen Handlungen und freier Interaktion, um den Nutzenden einen kleinen Leitfaden zu geben aber auch Möglichkeit zum Experimentieren zu lassen.
* Das Raumschiff soll den Ankerpunkt der Anwendung darstellen, wie es auch im Hörspiel beschrieben wird.


### Allgemeine Informationen
* Gruppe N°10
* Mitglieder: Kappes, Wagner, Ackermann, Schunn & Steiger
* Die ausführbare APK befindet sich im [/dist](https://github.com/dsteige1/AuditorySpaces_Gruppe10/tree/master/dist)-Ordner

---

### Technische Umsetzung
#### Generell
* Modellierung mit **Blender** und **3ds Max** (je nach System und/oder persönlicher Präferenz)
* Basale Materialien wurden in der Modellierungssoftware erstellt und nach dem Import in Unity angepasst
* Export der Modelle vorzugsweise im FBX-Format
* Programmierung der Interaktion in **Unity**
* Das **GoogleVR**-Paket (GVR) für Unity ermöglicht den Zugriff auf diverse Skripte und Komponenten, die die Programmierung von VR-Anwendungen für mobile Endgeräte erleichtern (z.B. den Zugriff auf das Gyroskop-System des Smartphones und folglich den Retina-Pointer und ein entsprechendes Event-System, um durch 'Blicke' mit Objekten interagieren zu können)
* Built der fertigen Applikation via Android SDK für die **Android**-Plattform

#### Modelle
* Größere Architekturen haben wir weitgehend selbst modelliert. Bei einigen Objekten haben wir uns an freien Modellen aus dem Internet bedient:
    * _Cartoon_Lowpoly_Car.fbx_ von [TurboSquid](https://www.turbosquid.com/3d-models/cartoon-city-car-3d-model-1362622)
    Darauf basiert auch das Modell _Car_interior.fbx_
    * _scifi_cartoon_rocket.obj_ von [Free3D](https://free3d.com/de/3d-model/cartoon-rocket-878331.html)
    * _SPIDER_PARA_VENTA.obj_ von [TurboSquid](https://www.turbosquid.com/3d-models/3d-spacecraft-1288438)
    * Die Baumelemente, welche in Blender zu einem Waldkontext (_Forest.fbx_) zusammengefügt wurden:
        * [Low Poly Tree](https://www.turbosquid.com/3d-models/sample-trees-c4d-free/1008420), [Low Poly Trees](https://www.turbosquid.com/3d-models/trees-3d-model-1189906)

    * _street_environment.fbx_ von [CGTrader](https://www.cgtrader.com/free-3d-models/exterior/street/street-87943b69-51c4-4f67-8d3c-ea772a7362af)

Built with Unity-Version 2019.2.12f1

---
