# OutlookContacts

GMail 안에 있는 연락처를 CSV로 Export를 한 뒤, 이 내용을 Outlook의 연락처로 등록하기도 하고,
Outlook의 연락처를 Gmail 안에 Import 해서 GMail 안의 연락처에 등록할 수 있도록 하기 위한 프로그램이다.

일단 이 작업을 하려면, Export 하는 데이터의 구조를 먼저 파악해야 하므로
이 부분을 먼저 설정하도록 한다.

이 처리를 할 때, 기준이 되는 데이터가 결정될 필요가 있다.
기준 데이터 부분이 있어 이 곳에 저장된 정보가 기준이 되고, 이 안의 값을 업데이트 한 뒤, 
최종적으로 동기화 되게 해야 한다.

기준은 Outlook으로 설정한다.

Outlook -> Google Contact 로 업데이트 할 수 있게 하며,
Google Contact 에서 Export(Outlook 스타일로)한 값을 Outlook 에 적용하게 한다.

이 때, 이름이 베이스가 되고 Email 주소를 함께 Key로 사용하게 한다.

상호간의 데이터 Import Export는 CSV로 할 수 있게 한다.


TODO : Google API를 Nuget으로 받아 처리 될 수 있도록 한다.