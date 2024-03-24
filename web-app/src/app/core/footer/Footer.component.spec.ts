import { ComponentFixture, TestBed } from '@angular/core/testing';
import { FooterComponent } from './footer.component';

describe('FooterComponent', () => {
  let component: FooterComponent;
  let fixture: ComponentFixture<FooterComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [FooterComponent],
    }).compileComponents();

    fixture = TestBed.createComponent(FooterComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
  
  it('should be copyrighted to BrainWare Inc for the current year', () => {
    // Not a great test as it practically duplicates the functionality;
    // however, would want to be alerted to any unintended changes. 
    // (And a real footer component could have additional functionality also needing tested.)
    const fixture = TestBed.createComponent(FooterComponent);
    const year: number = new Date().getFullYear();
    fixture.detectChanges();
    const compiled = fixture.nativeElement as HTMLElement;
    expect(compiled.querySelector('p')?.textContent).toContain(
      `© ${ year } - BrainWare, Inc`
    );
  });
});
