import { Component } from '@angular/core';

@Component({
  selector: 'app-dashboard',
  template: `
    <app-host-dashboard *abpPermission="'IntelliFireSystems.Dashboard.Host'"></app-host-dashboard>
    <app-tenant-dashboard *abpPermission="'IntelliFireSystems.Dashboard.Tenant'"></app-tenant-dashboard>
  `,
})
export class DashboardComponent {}
