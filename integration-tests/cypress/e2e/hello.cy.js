describe('template spec', () => {
  it('passes', () => {
    cy.visit('http://localhost')
    cy.get('.navbar-brand').click()
    cy.get(':nth-child(1) > .nav-link').click()
    cy.get(':nth-child(2) > .nav-link').click()
  })
})